#!/usr/bin/perl

#################################
#								#
#	REGEX (exemples)			#
#								#
#################################

#-------------------------------------- RAPPELS
#### TESTER MATCH : s'applique à $_
if(/PATTERN/){
}
#### EQUIVALENCE :
#### OPERATEUR =~ / !~ : place le contenu du match dans la var
if($str =~ /PATTERN/){
}

###################### MATCH ##################################

#================== si la ligne se termine par un '/'
if (/\/$/){}

#================== en début de ligne, après '/dev/' et avant espace
s/^\/dev\/([^\s]+)\s.*/$1/;

#================== en fin de ligne, et après espace
s/.* ([^\s]+)$/$1/;

########## répertoires
#=================== test si répertoire absolu	
if($repertoire =~ /^\//){} # = commence par /

#=================== enlever le './' initial du chemin relatif
$repertoire =~ s/^\.\///;

#=================== enlever le '.' du répertoire courant
$repertoire =~ s/^\.//;

#=================== PRECEDENT (ce qui précède un caractère)
# ^([^§]+) = un ou plusieurs fois un caractère qui n'est pas un '§'
# § = un caractère '§'
# .* = n'importe quoi
# $1 = on garde ce qui précède le caractère '§'
$preceding =~ s/^([^§]+)§.*/$1/;

#=================== SUIVANT (ce qui suit un caractère)
$following =~ s/^[^§]+§(.*)/$1/;

#=================== si la ligne n'est pas une ligne vide
# ajouter le nom du répertoire (et un '/' littéral) devant celui du fichier
s/(.+)/$absolute_directory\/$1/;

#=================== éliminer un caractère en fin de ligne 
# éliminer le ':' qui suit le nom du répertoire
s/:$//;


# ^ = début de ligne
# $home = le répertoire domicile
# \/ = un slash '/' littéral (protégé par un '\')
# [^\/] = un caractère qui n'est pas un slash '/' littéral
# + = un ou plusieurs fois le caractère qui précède
# [^\/]+ = un ou plusieurs fois un caractère qui n'est pas un slash '/' littéral
# .* = n'importe quoi
# $1 = ce qui à été trouvé à l'intérieur des premières parenthèses : ici :
# ^($home\/[^\/]+)
$surveiller =~ s/^($home\/[^\/]+).*/$1/;


######### MATCH SUR PLUSIEURS LIGNES
open FILE, $filename
	or die "Can't open '$filename' : $!'";
my $lines = join '', <FILE>;
$lines =~ s/^/$filename: /gm;


######### différence commentaire / code
if (/\s*#/) {
 # c'est du commentaire
} else {
 # c'est du code		
}

######### exemple avec var
# tant que la ligne contient une variable
while (/\$\w+/){}
# supprimer la variable, et tout ce qui précède
s/[^\$]*(\$\w+)//;


#####################################################
# si la ligne contient une définition d'alias
# "^ *" permet d'éventuels espaces devant "alias"
# "[^\s]+=" il faut au moins un caractère (qui n'est pas un 'espace généralisé' = \s)
# devant le signe "=" pour que cela définisse un alias
if (/^ *alias [^\s]+=/) {}

# extraire l'alias de la ligne
$alias_existant =~ s/^ *alias (.+)=.*/$1/;



###################### SUBSTITUTION ###########################

#====== récupérer le nom d'un fichier sans le path
# --- seule différence si /usr/local/bin/ (=> dir et non cmd à la fin)
# version simple
$nom_du_fichier =~ s/.*\///; # ne retourne rien
# version ...
$nom_du_fichier =~ s/.*\/([^\/])/$1/; # retourne bin/

#====== supprimer le 1er espace et tout ce qui suit
$test =~ s/ .*//;

#====== standardiser la sortie erreur standard
# ajouter la sortie erreur (2) à la sortie standard (1)
$chemin_executable = `which $nom_programme 2>&1`;
# standardiser la réponse si pas trouvé
$chemin_executable =~ s/which: .*/Not found/;
chomp $chemin_executable;
# vérifier qu'il existe
if ($chemin_executable eq "Not found") {
	# ...
}

#====== enlever les éventuels espaces 'parasites'
$test =~ s/ //;

#====== premier nombre entre espaces blancs (\s*)
$pid =~ s/\s*(\d+)\s.*/$1/;

#====== supprimer les caractères de ponctuation
s/[.,"';:!?\(\)]//g;

#====== mettre tout en minuscules
s/(.*)/\L$1/g;


#===============================================
foreach(@fe_arr){
	chomp;
	print "BEFORE ======= " . $_ . " \n";
	#==== supprimer les commentaires		
	# s/#(.*)//;
	#==== supprimer tout après le premier espace		
	s/\s(.*)//; # parenthèses non obligatoire => juste si on veut récupére ce qui vient après
	print "\$1 ======= " .  $1 . " \n";
	print "AFTER ======= " .  $_ . " \n";				
	$fe .= $_ . "\n";	
}
			
