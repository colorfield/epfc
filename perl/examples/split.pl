#!/usr/bin/perl

$string = "Un string avec des espaces    !";


########################## MODE PAR DEFAUT (séparateur = \s)
# !! ne prend pas les espaces à la fin !!

$_ = $string;
@vect = split;
# mode par défaut de 'split' : 
#	agit sur le contenu de $_
#	utilise \s (= whitespace = espace blanc) comme séparateur
# donc : sépare $_ sur les espaces blancs et met les morceaux dans
# les éléments successifs d'un vecteur
# ici on assigne ce vecteur à la variable @vect

foreach (@vect) {
	print ;
	print "\n";
}

########################## MODE EXPLICITE
# !! PREND les espaces à la fin !!

$_ = $string;
@vect = split (/\s/, $_);
# la même chose , mais explicitement : 
#	agit sur le contenu de $_
#	utilise \s (= whitespace = espace blanc) comme séparateur

foreach (@vect) {
	print ;
	print "\n";
}


########################## MODE AVEC UN AUTRE SEPARATEUR

$_ = $string;
@vect = split (/a/, $_);
# la même chose , mais avec le caractère 'a' comme séparateur : 
#	agit sur le contenu de $_
#	utilise le caractère littéral 'a' comme séparateur
# donc : sépare $_ sur le caractère littéral 'a' et met les morceaux dans
# les éléments successifs d'un vecteur

foreach (@vect) {
	print ;
	print "\n";
}

