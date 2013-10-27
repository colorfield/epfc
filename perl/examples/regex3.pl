#!/usr/bin/perl

#################################
#			REGEX test 			#
#################################

#----------------- USAGE ------------------#
#	perl regexTest ENTREE PATTERN

$PATTERN 	= '';						# définir le pattern
$STD_IN 	= '';						# définir l'entrée

if($PATTERN eq ''){$STD_IN = shift;}	# si non définit, prend le 1e param
if($PATTERN eq ''){$PATTERN = shift;}	# si non définit, prend le 2e param

while(<>){								# prise d'une ligne à la fois
  chomp;								# supprime le retour à la ligne
  if(/$PATTERN/){						# test						
	print "MATCH : | $` <$&> $' |\n";	# affiche : before <MATCH> after
  }else{
	print "NO MATCH FOR : | $_ |\n";
  }
}