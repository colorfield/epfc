#!/usr/bin/perl

######################## CONSTRUCTION
###### 1ere forme
#======== construction des cles
%traduction1 = ('january','february','march');
#======== ecriture par clé
$traduction1{'january'}='janvier';
$traduction1{'february'}='fevrier';
$traduction1{'march'}='mars';

###### 2eme forme construction et ecriture
# construction
%traduction2 = 
		( 
		  'january'  => 'janvier',
		  'february' => 'fevrier',
		  'march'    => 'mars' 
		);

######################## PARCOURIR PAR CLE
foreach (keys %traduction1){
	# !! imprime dans le désordre !!
	print "mois [CLE] $_ = $traduction1{$_} \n";
}


########################################
# cf aussi fichiers associés à Exa2008 (occurences et variables)
# EXTRAITS

while (<TEXT>) {
	# mettre les mots de la ligne dans le vecteur @mots
	@mots = split;
	# parcourir le vecteur ($_ = le mot)
	foreach (@mots) {
		# incrémenter le compteur du hash %mots pour la clé = le mot
		$mots{$_}++;	
	}
}

foreach (sort keys %mots) {
	# mettre les lignes d'affichage dans le vecteur @occurences
	# pour un autre usage	
	push (@occurences, "$mots{$_}\t: $_\n");
	# imprime chaque ligne	
	print;	
}




######################## Exemple

%hash = (
		1 => 'un',
		2 => 'deux',
		3 => 'trois'
);

# KEYS = liste des cles
print keys(%hash);
print "\n";

# EACH = retourne paire cle - valeur suivante
($clef,$valeur) = each(%hash); 
print 'CLEF = ' . $clef . ' VALEUR = ' . $valeur;
print "\n";
($clef,$valeur) = each(%hash); 
print 'CLEF = ' . $clef . ' VALEUR = ' . $valeur;
print '\n';
