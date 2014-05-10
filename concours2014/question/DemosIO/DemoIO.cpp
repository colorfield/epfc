/*
Programme de démo des E/S pour le concours de programmation EPFC 2014.
Vous ne devez pas modifier le format de ces E/S
(si ce n'est enlever le message "DemoIO..."!)

Ce programme lit deux nombres length et nbCuts sur les 2 premières lignes de
l'entrée standard. Il lit ensuite nbCuts nombres (un par ligne) et écrit sur
la sortie standard le texte "Somme : " suivi de la somme de tous les nombres
lus et d'un saut de ligne.
*/

#include <iostream>

using namespace std;

int main() {
  cout << "DemoIO C++\n"; // Enlevez ce message dans votre programme!
  unsigned length;
  cin >> length;
  unsigned nbCuts, somme = 0;
  cin >> nbCuts;
  for(unsigned k = 0; k < nbCuts; ++k) {
    unsigned cutPlace;
    cin >> cutPlace;
    somme += cutPlace;
  }
  cout << "Somme : " << length + nbCuts + somme << endl;;
}


