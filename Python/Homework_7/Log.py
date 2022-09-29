import datetime
now = datetime.datetime.now()

def Add_log(text):
    log_file_name = 'log.txt'
    with open (log_file_name, 'a+') as log_file:
        if type(text) == str:
            log_file.writelines(f'Время        {now.now()}\n'
                                f'Выражение    {text}\n')
        else:
            log_file.writelines(f'Ответ        {text}\n\n')


def Print_log():
    log_file_name = 'log.txt'
    with open (log_file_name, 'r') as log_file:
        print(log_file.read())


def Del_log():
    log_file_name = 'log.txt'
    with open(log_file_name, 'w') as log_file:
        return
