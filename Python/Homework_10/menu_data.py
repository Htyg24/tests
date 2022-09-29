# import Import_contacts
# import Print_data
# import Add_contact
# import Export
#
# def Menu():
#     dossier = Import_contacts.Start_add_contacts()
#     mod = input('''    1) Доавтиь запись
#     2) Импортировать контакт
#     3) Экспортировать контакт
#     4) Вывести справочник
#     5) Выход
#     ''')
#     while mod != '5':
#         if mod == '1':
#             dossier = Add_contact.New_contact(dossier)
#         elif mod == '2':
#             dossier = Import_contacts.Start_add_contacts()
#         elif mod == '3':
#             Export.Export_txt(dossier)
#         elif mod == '4':
#             Print_data.Print(dossier)
#         else:
#             print('Введите коректное значение')
#         mod = input('''
#     1) Доавтиь запись
#     2) Импортировать контакт
#     3) Экспортировать контакт
#     4) Вывести справочник
#     5) Выход
#     ''')