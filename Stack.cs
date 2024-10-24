using System;

class Stack
{
    // закрытые члены класса
    private char[] stck; //массив, содержащий стэк
    private int tos; //индекс вершины стэка
    
    // построить пустой класс для реализации стэка заданного параметра
    public Stack(int size)
    {
        stck = new char[size]; //рапсределяем память стэка
        tos = 0;
    }
    
    // поместить символы в стэк
    public void Push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine('Stack is Full');
            return;
        }

        stck[tos] = ch;
        tos++;
    }
    
    // извлечь символ из стека
    public char Pop()
    {
        if (tos == 0)
        {
            Console.WriteLine('Stack is empty');
            return (char)0;
        }

        tos--;
        return stck[tos];
    }
}