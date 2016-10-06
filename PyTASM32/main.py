# -*- coding: utf-8 -*-
import subprocess
import re

id = input( "Введите название *.asm файла (без ввода .asm): " )
def Assembly( id ):
    p = subprocess.Popen( "BIN32\TASM32.exe /l /zi " + id + ".asm", shell = True, stdout = subprocess.PIPE )
    assembly_output = p.stdout.read().decode( 'cp866' )
    return assembly_output

def Compile( id ):
    p = subprocess.Popen( "BIN32\TLINK32.exe /v " + id + ".obj", shell = True, stdout = subprocess.PIPE )
    compile_output = p.stdout.read().decode( 'cp866' )
    return compile_output
	
def ErrorPrnt(error):
	return "Название ошибки: " + error[0]
	
print("Ожидайте, ассемблируем файл " + id + ".asm")

result = re.findall(r'Error messages:\s*(.*?)\r\n', Assembly(id), re.DOTALL)
if result[0] == 'None':
    print("Ожидайте, компилируем файл " + id + ".asm\n")
    result = re.findall(r'Fatal:', Compile(id), re.DOTALL)
    if result[0] == 'Fatal:':
        error = re.findall(r'Fatal:\s*(.*?)\r\n', Compile(id), re.DOTALL)
        print(ErrorPrnt(error))
else:
    print("Найдена ошибка!")
    resultA = re.findall(r'\*\*Fatal\*\*', Assembly(id), re.DOTALL)
    if resultA[0] == '**Fatal**':
        error = re.findall(r'\*\*Fatal\*\*(.*?)\r\n', Assembly(id), re.DOTALL)
        print(ErrorPrnt(error))
