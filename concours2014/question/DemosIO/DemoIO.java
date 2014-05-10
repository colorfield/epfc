/*
Programme de démo des E/S pour le concours de programmation EPFC 2014.
Vous ne devez pas modifier le format de ces E/S
(si ce n'est enlever le message "DemoIO..."!)

Ce programme lit deux nombres length et nbCuts sur les 2 premières lignes de
l'entrée standard. Il lit ensuite nbCuts nombres (un par ligne) et écrit sur
la sortie standard le texte "Somme : " suivi de la somme de tous les nombres
lus et d'un saut de ligne.
*/

import java.util.*;

public class DemoIO {
  public static void main(String[] args) {
    System.out.println("DemoIO Java");
    Scanner s = new Scanner(System.in);
    int length = s.nextInt();
    int nbCuts = s.nextInt(), somme = 0;
    for(int k = 0; k < nbCuts; ++k) {
      int cutPlace = s.nextInt();
      somme += cutPlace;
    }
    System.out.println("Somme : " + (length + nbCuts + somme));
  }
}