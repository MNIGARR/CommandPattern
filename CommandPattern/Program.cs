using CommandPattern;


double number1 = 10;
double number2 = 0;


AddCommand adding = new();
adding.Operation(number1, number2);

DivideCommand division = new();
division.Operation(number1, number2);


