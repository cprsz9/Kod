#include <iostream>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <sstream>  
#include <stdlib.h>

using namespace std;

class Uzytkownik
{

private:
	string imie;
	string nazwisko;
	string nrKartyKredytowej;
public:
	string pin;
	int pieniadzeKonto = 100;
	int pieniadzeGotowka = 100;

	void stworzUzytkownika() {
		srand(time(NULL));
		cout << "Podaj imie: "; cin >> imie;
		cout << "Podaj nazwisko: "; cin >> nazwisko;

		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				int x = rand() % 9 + 1;
				string y = to_string(x);
				nrKartyKredytowej = nrKartyKredytowej + y;
			}
		}

		cout << "Twoj numer karty kredytowej: " << nrKartyKredytowej << endl;


		for (int j = 0; j < 4; j++) {
			int x = rand() % 9 + 1;
			string y = to_string(x);
			pin = pin + y;
		}
		cout << "Pin: " << pin << endl;
	}

	void pokazUzytkownika() {
		cout << "---------------------------" << endl;
		cout << "Imie: " << imie << endl;
		cout << "Nazwisko: " << nazwisko << endl;
		cout << "Nr karty kredytowej: " << nrKartyKredytowej << endl;
		cout << "PIN: " << pin << endl;
		cout << "Pieniadze w gotowce: " << pieniadzeGotowka << " zl" << endl;
		cout << "Pieniadze na koncie: " << pieniadzeKonto << " zl" << endl;
		cout << "---------------------------" << endl;

	}

	void pracuj() {
		srand(time(NULL));
		int zarobione = rand() % 350;
		cout << "Zarobiles " << zarobione << " zl!\n";
		pieniadzeKonto = pieniadzeKonto + zarobione;
	}
};

