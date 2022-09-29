from aiogram.dispatcher.filters.state import StatesGroup, State
from aiogram.dispatcher import FSMContext
from aiogram import types
from config import dp
from Import_contacts import Add_contact

class FSM_add(StatesGroup):
    name = State()
    phone_number = State()
    birth = State()
    department = State()
    adress = State()


# def New_contact(contact = ''):
#     contact += ',T' + ',T'.join(input('Введите телефоны').split())
#     contact += ',B' + input('Введите дату рождения')
#     contact += ',B' + input('Введите отдел')
#     contact += ',A' + input('Введите адрес') + '\n'
#     contact = contact.split(',')
#     return Add_contact(contact)

@dp.callback_query_handler(text='Add', state=None)
async def Add(callback: types.CallbackQuery):
    await FSM_add.name.set()
    await callback.message.answer('Введите имя')

@dp.message_handler(state=FSM_add.name)
async def name(message: types.Message, state: FSMContext):
    with open('contact.txt', 'w') as contact:
        contact.write('N' + message.text)
    await FSM_add.next()
    await message.answer('Введите телефоны')

@dp.message_handler(state=FSM_add.phone_number)
async def phone_number(message: types.Message, state: FSMContext):
    with open('contact.txt', 'a') as contact:
        contact.write(',T' + ',T'.join(message.text.split()))
    await FSM_add.next()
    await message.answer('Дату рождения')

@dp.message_handler(state=FSM_add.birth)
async def birth(message: types.Message, state: FSMContext):
    with open('contact.txt', 'a') as contact:
        contact.write(',B' + message.text)
    await FSM_add.next()
    await message.answer('Введите отдел')

@dp.message_handler(state=FSM_add.department)
async def department(message: types.Message, state: FSMContext):
    with open('contact.txt', 'a') as contact:
        contact.write(',B' + message.text)
    await FSM_add.next()
    await message.answer('Введите вдрес')

@dp.message_handler(state=FSM_add.adress)
async def adress(message: types.Message, state: FSMContext):
    with open('contact.txt', 'a') as contact:
        contact.write(',A' + message.text + '\n')
    with open('contact.txt', 'r') as contact:
        local_info = contact.read().split(',')
        print(local_info)
        Add_contact(local_info)
    await state.finish()
