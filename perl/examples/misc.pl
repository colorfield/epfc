#!/usr/bin/perl


################# LIRE SUR ENTREE STANDARD ##########

$in = <STDIN>;

################# REDIRIGER ENTREE/ERREUR STANDARD + BOOLEAN ##########
$url = "http://www.google.be";
$access_server = `curl -I $url > /dev/null 2>&1 && echo OK || echo NOK`;
print $access_server . "\n";


# redirection erreur vers sortie standard ---- ! fonctionne pas !
$test = `which turlututu 2>&1`;
print "---> $test";

# redirection erreur vers null  ---- ! fonctionne pas !
#$test = `which turlututu 2>/dev/null`;
$test = `which turlututu`;
print "---> $test";


################ APPELS SYSTEMES #####################
# Appel avec BACKQUOTES
$hom = `/bin/ls ~/`;
print $hom;
# Appel avec SYSTEM
$testWr = 'Test';
system("echo -n $testWr > ~/testEcriture");

# lancer sans quitter le prompt
system("firefox &");

################ Test accès avec UDPGET ########

$udp = `~/udpget 192.168.30.130 0.1 cs.version.server > /dev/null 2>&1 && echo OK || echo NOK`;
#$udp = `udpget 192.168.30.130 0.1 index.html`;
#$udp = `~/udpget 192.168.30.130 0.1 cs.version.server`;
print "UDP GET : " . $udp;


################# TEMPS ############################
#### bulletproof
system("date --set='$serverdate'");
#### network time protocol (ntp)

