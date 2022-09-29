from Cliet_data import Info

def enum(num, file):
    for c in range(len(Info)):
        for k in range(len(Info[c])):
            if Info[c][0] == f'I{num}' and k != 0:
                file.writelines(f'{Info[c][k]}, ')

def Export_txt(dossier):
    mod = '1'
    # mod = input('В каком формате сохранить? \n'
    #             '1. TXT\n'
    #             '2.CSV')
    while '1' > mod or mod > '2':
        mod = input('Введите корректное значение\n'
                '1. TXT\n'
                '2.CSV')
    print('\n\n')
    with open('text1.txt', 'w') as file:
        pass
    with open('text1.txt', 'a', encoding='utf-16') as file:
        for i in range(len(dossier[0])):
            enum(dossier[0], i, file)
            enum(dossier[1], i, file)
            enum(dossier[2], i, file)
            file.writelines('\n')