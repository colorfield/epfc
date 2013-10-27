#!/usr/bin/perl

#=======================================================================
# Ecrit un fichier diff
# sur base de deux fichiers (params 1 et 2)
# 3e param = mode du fichier diff ("m" --manual ou "r" --raw [default]) 
#=======================================================================

# params
$file1 = shift;
$file2 = shift;
$diffMod  = shift;
chomp $diffMod;

# subroutine call
&writeDiff($file1, $file2, $diffMod);

#=======================================================================

sub writeDiff{
	my ($f1, $f2, $mode) = @_;
	my $fileDiff = "$f1\-$f2.diff";
	my $diffOut;
	my $diffManOpt = "-y --left-column --suppress-common-lines";
	my $stdErr;
	## !! doit encore gérer "l'erreur standard personnalisée" :
	## retourne "isEmpty" si erreur de diff

	###### verification au moins deux fichiers
	if ($f1 eq "" || $f2 eq ""){
		print "Entrer aux moins deux paramètres concernant des fichiers \n";
		exit; 
	}  

	###### mode par défaut	
	if ($mode eq ""){$mode = "r";}

	
	###### $diffOut : redirige std err pour le test suivant (notEmpty)
	#===== si comparaison manuelle : on ne souhaite que les différences, sans rien d'autre
	if($mode eq "m"){

		$diffOut = `/usr/bin/diff $diffManOpt $f1 $f2 2>/dev/null`;		
				
		# output 2 array
		@dif = split(/\n/,$diffOut);
		# @dif = $diffOut; !! non !!

		# vide diffOut
		$diffOut = "";

		# supprime tout à partir de la première tabulation
		foreach(@dif){
			chomp;
			s/\t.*//;
			$diffOut .= $_ . "\n";
			# debug
			# print "== NEW LINE == $_";			
		}
		
		print "Fichier -manuel- écrit \n";

	#===== sinon on prend le diff "raw"
	}elsif ($mode eq "r"){
		$diffOut = `/usr/bin/diff $f1 $f2 2>/dev/null`;
		print "Fichier -raw- écrit \n";
	}

	###### notEmpty : si la différence n'est pas nulle, on écrit le diff
	if ($diffOut ne "") {	
		open(OUT, ">$fileDiff");				
		print OUT $diffOut;
		close OUT;
	}else{
		print "Aucune différence entre les fichiers $f1 et $f2 \n";
	}
}
