import logging
from aiogram import Dispatcher, Bot
import os
from aiogram.contrib.fsm_storage.memory import MemoryStorage

storage = MemoryStorage()

API_TOKEN = '5444000961:AAHOaRWOsYXkvs8ufgU9EvXJuxFKg-JK2xM'

# Initialize bot and dispatcher
bot = Bot(token=API_TOKEN)
dp = Dispatcher(bot, storage=storage)

# Configure logging
logging.basicConfig(level=logging.INFO)
