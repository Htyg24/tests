from Log import Add_log

def Convert(file_name = 'text.txt'):
    file = open(file_name, 'r')
    text = file.readline()
    modify: str
    if 'j' in text:
        modify = 'complex'
    elif '.' in text:
        modify = 'float'
    else:
        modify = 'int'
    print(f'Ваше выражение {text},\nимеет тип {modify}')
    Add_log(text)
    expression = []
    sign = '+-*/()'
    num = ""
    for i in text:
        if i in (sign):
            if num != "":
                expression = Modify(expression, num, modify)
                num = ''
            expression.append(i)
        else:
            num += i
    if num != '':
        expression = (expression, num, modify)
    return expression


def Modify(expression, num, modify):
    if modify == 'int':
        expression.append(int(num))
    elif modify == 'float':
        expression.append((float(num)))
    else:
        expression.append(complex(num))
    return expression