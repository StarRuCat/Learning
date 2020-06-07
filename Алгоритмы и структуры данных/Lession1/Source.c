#include <stdio.h>
#include <math.h>

int main(int argc, char *argv[]) {
	///Индекс массы тела
	double h, m;
	double I;

	printf("Input growth in meters and weight in kilograms: ");
	scanf("%lf %lf", &h, &m);

	I = m / (h * h);
	printf("You BMI is: %lf", I);



	///Большее из четырех цисел
	double a;
	double b;
	double c;
	double d;
	double max;

	printf("Input four numbers: ");
	scanf("%lf %lf %lf %lf", &a, &b, &c, &d);
	
	max = a;
	if (max < b) { max = b; }
	if (max < c) { max = c; }
	if (max < d) { max = d; }
	printf("Max is: ", max);

	///Обмен значениями
	double e;
	double f;

	printf("Input two numbers: ");
	scanf("%lf %lf", &e, &f);

	e = e + f - (f = e);

	getch();
	return 0;
}