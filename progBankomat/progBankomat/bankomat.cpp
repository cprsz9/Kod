#include <cmath>
#include <cstdlib>
#include <ctime>
#include <sstream>  
#include <stdlib.h>

using namespace std;

class Bankomat {
	int iloscPieniedzy;
public:
	void wyplacPieniadze(Uzytkownik& u) {
		int wyplac;
		srand(time(NULL));
		string podanyPIN;
		iloscPieniedzy = rand() % 1000;
		cout << "W bankomacie jest " << iloscPieniedzy << " PLN." << endl;


		cout << "Podaj PIN: ";  cin >> podanyPIN;
		cout << "Na koncie masz: " << u.pieniadzeKonto << endl;
		if (podanyPIN == u.pin) {
			cout << "Ile chcesz wyplacic pieniedzy?: "; cin >> wyplac;
			if (wyplac > iloscPieniedzy || wyplac > u.pieniadzeKonto) {
				cout << "BLAD! Brak pieniedzy!";
			}
			else
			{
				u.pieniadzeKonto = u.pieniadzeKonto - wyplac;
				u.pieniadzeGotowka = u.pieniadzeGotowka + wyplac;
				cout << "Pomyslnie wyplacono " << wyplac << " PLN!" << endl;
			}
		}
		else
		{
			cout << "Niepoprawny PIN!!!" << endl;
		}

	}

	void wplacPieniadze(Uzytkownik& u) {
		int wplac;
		string podanyPIN;

		cout << "Podaj PIN: ";  cin >> podanyPIN;
		cout << "W gotowce masz: " << u.pieniadzeGotowka << endl;
		if (podanyPIN == u.pin) {
			cout << "Ile chcesz wplacic pieniedzy?: "; cin >> wplac;
			if (wplac > u.pieniadzeGotowka) {
				cout << "Masz za malo pieniedzy w gotowce!";
			}
			else
			{
				u.pieniadzeKonto = u.pieniadzeKonto + wplac;
				u.pieniadzeGotowka = u.pieniadzeGotowka - wplac;
				cout << "Pomyslnie wplacono " << wplac << " PLN!" << endl;
			}
		}
		else
		{
			cout << "Niepoprawny PIN!!!" << endl;
		}
	}
};
