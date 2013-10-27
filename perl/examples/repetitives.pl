#!/usr/bin/perl

q{
next(); 		passe à la boucle suivante
last(); 		équivalent à break
unless(condition); 	break si false
};

############ WHILE (tant que)
# $i = 0;
# while ($i < 10) {print $i; $i++; }

############ UNTIL (jusqu'à ce que)

$i = 0;
until ($i == 10) {print $i; $i++;}

############ FOR
# for ($i=0; $i < 10; $i++) {print $i;}

############ FOREACH

q{
foreach $Couleur ('jaune','vert','bleu') { ... }
        la variable couleur prend successivement les
        valeurs jaune, vert et bleu
foreach $var (@tableau1, @tableau2, $I, $K, 10)
        la variable $var prend successivement toutes les
        valeurs scalaires contenues dans $tableau1 ...
        jusqu'à la valeur 10
};
