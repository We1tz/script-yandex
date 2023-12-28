import random
import time
from bs4 import BeautifulSoup
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.options import Options as ChromeOptions
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time
import pyautogui
import os

all_headers = []


def click_button():
    button_xpath = ('//a[@class="Button2 Button2_type_link Button2_size_l Button2_theme_action Button2_view_lyceum '
                    'y1b87d--comments__link"]')
    button = WebDriverWait(driver, 10).until(EC.element_to_be_clickable((By.XPATH, button_xpath)))
    button.click()
    time.sleep(2)


def navigate_back():
    time.sleep(5)
    driver.back()



def upload_file(driver, file_path):

    absolute_file_path = os.path.abspath(file_path)


    input_element = WebDriverWait(driver, 10).until(
        EC.presence_of_element_located((By.ID, 'xuniq2'))
    )

    input_element.send_keys(absolute_file_path)


def wait_and_click(xpath):
    WebDriverWait(driver, 10).until(EC.element_to_be_clickable((By.XPATH, xpath))).click()


def process_header_page(text_task, count_tasks):
    all_headers.remove(text_task)
    number_lesson = count_tasks
    wait_and_click(f'//*[contains(text(), "{text_task}")]')

    def process_tasks_page(n):
        directory_path = f"{n}"
        os.chdir(directory_path)

        contents = os.listdir()
        return contents

    time.sleep(3)
    tasks = process_tasks_page(number_lesson)

    for task in tasks:
        try:
            wait_and_click(f'//*[contains(text(), "{task}")]')
            choice_task = random.randint(1, 3)
            upload_file(driver, f'{task}/{choice_task}.cs')
            navigate_back()

        except Exception as e:
            print(f'Произошла ошибка: {e}')


driver = webdriver.Chrome()
url = 'https://lms.yandex.ru/courses/1044/groups/18927'
driver.get(url)


def remove_header(text):
    all_headers.remove(text)
    print('Удален урок - ', text)


def start_script():
    html_code = driver.page_source
    soup = BeautifulSoup(html_code, 'html.parser')
    headings = soup.find_all('h4')
    check_tasks = soup.find_all('span', class_='lesson-card__full-caption')

    for heading, tasks_span in zip(headings, check_tasks):
        tasks_text = tasks_span.get_text(strip=True)

        tasks = str(tasks_text).split()[0]
        tasks_done = tasks.split('задач')[0]

        number1 = tasks_done.split('/')[0]
        number2 = tasks_done.split('/')[1]

        if number1 != number2:
            all_headers.append(heading.text.strip())

    for header in all_headers:
        h_number = (header.split('.'))
        if os.path.exists(h_number[0]):
            print('Есть урок', h_number[0])
        else:
            print(f'Нет директории для урока {h_number[0]}')
            remove_header(header)


def update_tasks():
    for correct_header in all_headers:
        heading_text_to_find = correct_header
        number_tasks = (correct_header.split('.')[0])
        process_header_page(heading_text_to_find, number_tasks)
        break


input('Введите любой текст, для запуска: ')
start_script()
update_tasks()

driver.quit()
