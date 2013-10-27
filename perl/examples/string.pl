#!/usr/bin/perl

q{
   * chop() enlève le dernier caractère d'une chaîne;
   * chomp() enlève le dernier caractère d'une chaîne si celui-ci est un délimiteur de fin de ligne;
   * chr() convertit une valeur entière en le caractère correspondant du code ASCII;
   * hex() renvoie la valeur décimale correspondant à une chaîne de caractères héxadécimaux;
   * oct() renvoie la valeur décimale correspondant à une chaîne de caractère octaux;
   * index() renvoie la position de la première occurrence d'une sous chaîne dans une chaîne;
   * lc() convertit une chaîne de caractères en caractères minuscules;
   * length() indique la longueur en caractère d'une variable scalaire;
   * rindex() renvoie la position de la dernière occurrence d'une sous chaîne dans une chaîne;
   * substr() permet d'extraire d'une chaîne une sous chaîne définie en position et longueur.

    eq  (égalité)              ne  (différence)
    lt  (inférieur)            gt  (supérieur)
    le  (inférieur ou égal)    ge  (supérieur ou égal)
};

# concaténation
$str1 = 'test';
$str2 = '123';
$str3 = $str1 . ' ' . $str2;
# print $str3;

# echappement de caractère
$str4='S\'il vous plait
ligne2
ligne3
';

# print $str4;
$str4=q@s'il vous plait@;

# insertion dans chaine
$str5="${str4}....";
print $str5;


