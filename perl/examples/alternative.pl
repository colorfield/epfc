#!/bin/perl

########### IF - ELSE
# $test = (5<10) ? print 'true' : print 'false';
$test = (5<10) ? 'true' : 'false';
print $test . "\n";
$test = (11<10) ? 'true' : 'false';
print $test . "\n";


########### CASE - ne fonctionne pas -> utilisation de Switch
# http://perldoc.perl.org/Switch.html

#$testCase = 
#  ($width = 10) ? "1.ten" :
#  ($width = 20) ? "2.ten" :
#  ($width = 30) ? "3.ten" :
#				  "default";

# $width = 20;
# print $testCase  . "\n";

use Switch;

switch ($width) {
	case 10{ print "1.ten"}
	case 20{ print "1.ten"}
	case 30{ print "1.ten"}
	else {print "default"}
}


########### OPERATEURS LOGIQUE : 	OR 	= || , AND = && 


