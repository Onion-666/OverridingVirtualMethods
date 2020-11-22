/*Переопределение виртуальных методов. В базовом классе имеется некоторый метод, который наследуется в производном классе. Нам нужно, чтобы наследуемый метод в производном классе был, но нас не устраивает, как этот метод выполняется. В производном классе мы хотим изменить способ выполнения унаследованного метода. Нужно использовать переопределение метода.
Переопределение метода подразумевает два этапа. Собственно переопределение, когда в производном классе описывается новая версия метода. Причем такая версия описывается с ключевым словом override. Но кроме этого, в базовом классе данный метод должен быть объявлен как виртуальный. Для этого в описании метода в базовом классе используются ключевое слово virtual.
При вызове виртуального переопределенного метода версия метода определяется не типом переменной, через которую вызывается метод, а классом объекта, на который ссылается объектная переменная.
Атрибут virtual наследуется. Если метод в базовом классе объявлен как виртуальный, то он останется виртуальным при наследовании и переопределении.
*/
using System;
class Alpha
{
    public int alpha;
    public virtual void Show()
    {
        Console.WriteLine("Класс Alpha: {0}", alpha);
    }
    public Alpha(int a)
    {
        alpha = a;
    }
}
class Bravo : Alpha
{
    public int bravo;
    public override void Show()
    {
        Console.WriteLine("Класс Bravo: {0} и {1}", alpha, bravo);
    }
    public Bravo(int a, int b) : base(a)
    {
        bravo = b;
    }
}
class Charlie : Bravo
{
    public int charlie;
    public override void Show()
    {
        Console.WriteLine("Класс Charlie: {0}, {1} и {2}", alpha, bravo, charlie);
    }
    public Charlie(int a, int b, int c) : base(a, b)
    {
        charlie = c;
    }
}
class Programm
{
    static void Main()
    {
        Alpha objA = new Alpha(10);
        objA.Show();
        Console.WriteLine();
        Bravo objB = new Bravo(20, 30);
        objA = objB;
        objA.Show();
        objB.Show();
        Console.WriteLine();
        Charlie objC = new Charlie(40, 50, 60);
        objA = objC;
        objB = objC;
        objA.Show();
        objB.Show();
        objC.Show();
    }
}

