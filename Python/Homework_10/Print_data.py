from aiogram import types
from main import dp

def enum(lockal_info, Info, num):
    for c in range(len(Info)):
        for k in range(1, len(Info[c])):
            if Info[c][0] == f'I{num}':
                lockal_info += Info[c][k][1: len(Info[c][k])] + '\n'
                return lockal_info
    return

@dp.callback_query_handler(text='Print')
async def Print_data(callback: types.CallbackQuery):
    await Print(callback)

from Cliet_data import Info


async def Print(callback: types.CallbackQuery, Info=Info):
    for i in range(len(Info[0])):
        lockal_info = ''
        lockal_info = enum(lockal_info, Info[0], i)
        lockal_info = enum(lockal_info, Info[1], i)
        lockal_info = enum(lockal_info, Info[2], i)
        print(lockal_info)
        if not lockal_info is None:
            await callback.message.answer(lockal_info)
    return