from aiogram import executor, types
from aiogram.types import InlineKeyboardButton, InlineKeyboardMarkup
from Import_contacts import Start_add_contacts
import Print_data
import Contact
from config import dp

file_name = 'dossier.txt'

@dp.message_handler(commands='data', state=None)
async def calculate(message: types.Message):
    await message.answer('Данные сотрудников', reply_markup=inkb)

inkb = InlineKeyboardMarkup(row_width=5).add(InlineKeyboardButton(text='Импорт', callback_data='Import'),
                                             InlineKeyboardButton(text='Вывод', callback_data='Print'),
                                             InlineKeyboardButton(text='Создать', callback_data='Add'),
                                             InlineKeyboardButton(text='Экспортировать', callback_data='Export'),)

if __name__ == '__main__':
    executor.start_polling(dp, skip_updates=True)

Start_add_contacts()
