from Cliet_data import Info
from config import dp
from aiogram import types


@dp.callback_query_handler(text='Import')
async def Import(callback: types.CallbackQuery):
    Start_add_contacts()


def Start_add_contacts(file_name: str = 'dossier.txt', Info=Info):
    print('c')
    with open(file_name, 'r', encoding='UTF-8') as h:
        l = h.readline()
        while l != '':
            lockal_info = l.split(',')
            Add_contact(lockal_info)
            l = h.readline()
    return Info


def Add_contact(lockal_info):
    print(type(lockal_info))
    print(lockal_info)
    i = len(Info[0]) - 1
    Info[0][i].append(f'I{i}')
    Info[1][i].append(f'I{i}')
    Info[2][i].append(f'I{i}')
    Info[0].append([])
    Info[1].append([])
    Info[2].append([])
    for text in lockal_info:
        if text[0] == 'N' or text[0] == 'B' or text[0] == 'O' or text == 'B':
            Info[0][i].append(text)
        elif text[0] == 'T':
            Info[1][i].append(text)
        elif text[0] == 'A':
            Info[2][i].append(text[0: -1])
    return Info
