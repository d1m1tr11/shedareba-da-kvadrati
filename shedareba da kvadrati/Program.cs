Console.Write("sheiyvane ra ginda avides kvadratshi: ");


Console.WriteLine(kvadrati(Convert.ToInt32(Console.ReadLine())));

Console.Write("sheiyvane 2 ricxvi ro shevadaro: ");


Console.WriteLine(shedareba(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));




static int kvadrati(int num)
{
    int result = num * num;
    return result;
}

static int shedareba(int num1, int num2)
{
    int result;
    if (num1 > num2)
    {
        result = num1;
    }
    else { result = num2; }

    return result;
}
