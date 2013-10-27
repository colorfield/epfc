#!/usr/bin/perl

#################################
#								#
#	FICHIERS					#
#								#
#################################


############### AFFICHER ##################################
$atboot_version = `/bin/cat /etc/cs.version.atboot`;


############### BOUCLER DANS UN FICHIER ###################
# ligne par ligne
open(FILE_STREAM, "<$file");
while (<FILE_STREAM>) {
	chomp;
	$ligne = $_; # inutile, pour la lisibilité
}	
close FILE_STREAM;


############### LISTER ####################################
@lsh=`/bin/ls /home`;
foreach (@lsh) {
	chomp;
	if ( ! /^user$/){
	# si ce n'est pas 'user'
		if ( ! -f "/home/$_/.no_kde"){
		# et si ce compte a déjà ulilisé kde
		# (sinon on écraserait l'appel à 'atfirstlogins')
			system("/bin/cp /home/user/.bash_profile /home/$_ ");
		}
	}
}

# trier
system("sort $fcr > $fcs");


############### ECRIRE ##################################
#===== MODE BASH :
# -n : ne pas imprimer le caractère final de retour à la ligne
system("echo -n $hdnb > /etc/hd.nb");

#===== MODE PERL
# exemple complet sous files_write
$input = `ls pwd`;
$file = "/home/test";

open(FILE_STREAM, ">$file"); ## ouvrir en écriture
# open(FILE_STREAM, "<$file"); ## ouvrir en lecture
print FILE_STREAM $input;
close(FILE_STREAM);

#===== forcer l'écriture du fichier sur le disque (vider les tampons)
system("/bin/sync");



############### DROITS ##################################
# rendre le fichier lisible par tous
system("/bin/chmod 644 $file");

# mettre le bit setuid à un exécutable => exécuté avec droits du propriétataire (p.ex. root ...)
system("chmod +s $file");


############### COPIER ##################################
system("/bin/cp /home/user/.bash_profile /home/$_ ");
# ne pas avoir de confirmation
system("/bin/cp -f $in $out");

#============ écraser un fichier avec un autre (cp) => conserve les deux
$file_orig = "test_cp_orig";
$file_to_overwrite = "test_cp_new";
system("/bin/cp $file_to_overwrite $file_orig");

#============ changer le nom (mv)
system("/bin/mv test_mv_orig test_mv_orig-bak");

############### "SAUVEGARDER" et modifier ###############
$file = "truc";
system("mv -f $file $file.bak"); 	# ne pas avoir de confirmation : -f
open(IN, "<$file.bak"); 		# ouvrir en lecture 
open(OUT, ">$file"); 			# ouvrir en écriture
while(<IN>){
	$ligne = $_;
	print OUT "MODIF " . $ligne ;
}
close IN;
close OUT;
	
############### DIFFERENCE #############################
# utilisation de diff => cf files_diff

######################### détecte que le répertoire cherché a été créé
$detected = `fileschanged -r $surveiller | /usr/local/bin/detect $wait`;

######################### trouver un fichier
$created_path_file = `find $surveiller -name $file`;

############### TESTER EXISTENCE ##################################
# dossier
if ( -d "/home/user"){}
# fichier
if ( ! -f "/home/$_/.no_kde"){} 

# equivalent : pour fichiers, dossiers, ... => -e

############### LONGUEUR D'UN FICHIER #############################

# usage : $length = &filelength($file); 

sub filelength {
# fonction renvoyant la longueur en bytes du fichier donné en argument
# voir le script filelength.pl pour en 
($filename) = @_;
	$ll = `ls -l $filename`;
	chomp $ll;
	@ll = split (/ /,$ll);
	$length = $ll[4]; 
}

############### METTRE A JOUR DES FICHIERS ########################

# via la ligne de commande !
perl -p -i.bak -w -e 's/Auteur1/Auteur2/g' docs*.doc 

# équivalent => donner en param docs*.doc
#!/usr/bin/perl -w
$^I = ".bak";
while (<>){
	s/Auteur1/Auteur2/g;
	print;	
}


############### PARTITION RACINE ##################################
@df=`/bin/df`;

