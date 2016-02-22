#include <iostream>

using namespace std;

double omregning(int a, int b);
char YN;
int inn;
int kurs;

int main() {


	//double tall = lesFlyttTall(kurs, inn);

	cout << "Skriv inn kurs:" << endl;
	cin >> kurs;

	cout << "Skal det beregnes FRA norske kroner? J/N" << endl;

	cin >> YN;

	YN = tolower(YN);

	switch (YN)
	{

	case 'j':

		cout << "Oppgi ønsket beløp i NOK:" << endl;
		cin >> inn;
		cout << "Det blir " << omregning(inn, kurs) << " i fremmed valuta." << endl;
		break;

	case 'n':

		cout << "Oppgi ønsket beløp i fremmed valuta:" << endl;
		cin >> inn;
		cout << "Det blir " << omregning(inn, kurs) << " i NOK." << endl;
		break;

	default:
		cout << "Kun J/N!";
		break;
	}

	cout << endl;
	system("Pause");

	return 0;
}

double omregning(int a, int b) {
	switch (YN)
	{

	case 'j':
		return a * 100 / b;

		break;

	case 'n':
		return a * b / 100;

		break;
	}
}