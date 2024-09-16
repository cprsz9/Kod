#include <iostream>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <sstream>  
#include <stdlib.h>
#include "uzytkownik.cpp"
#include "bankomat.cpp"
using namespace std;


int main()
{
	Uzytkownik u1;
	Bankomat bankomat;
	u1.stworzUzytkownika();

	int wybor = 0;
	while (wybor != 9) {
		cout << "\n1 Pracuj" << endl;
		cout << "2 Wyplac pieniadze" << endl;
		cout << "3 Wplac pieniadze" << endl;
		cout << "4 Pokaz uzytkownika" << endl;
		cout << "9 Wyjdz" << endl;
		cout << "Co chesz zrobic? "; cin >> wybor;

		if (wybor == 1) {
			u1.pracuj();
		}
		if (wybor == 2) {
			bankomat.wyplacPieniadze(u1);
		}
		if (wybor == 3) {
			bankomat.wplacPieniadze(u1);
		}
		if (wybor == 4) {
			u1.pokazUzytkownika();
		}
	}

}
