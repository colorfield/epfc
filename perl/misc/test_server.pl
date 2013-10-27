#!/usr/bin/perl

########################################################
#   Test if a server is responding
#   Example of curl and bash usage through Perl
#
#   Param: 'a' (local Apache) | 'IP address' | 'host'
########################################################

$param = shift;
chomp $param;

############################### CASE 1 : LOCALHOST
if ($param eq 'a') {

  print "Testing Apache... ";
  
  # put ps output in array
  my @process = `ps aux`;
  $apacheIsUp = false;
  
  # loop throug output
  while($entry = shift(@process)){
    # do we get Apache?
    # print "$entry";
    # print "\n";
    if(/^apache/){
      $apacheIsUp = true;
      print "Apache UP";
      print "\n";
      # break after first occurence
      last;
    }
  }

  # Afficher si DOWN
  if($apacheIsUp == false) { 
     print "Apache DOWN";
     print "\n";
  }


############################### CASE 2 : DIST
} elsif ($param ne '') {

  print "Testing host $param... ";

  $url = "http://" . $param;
  
  # Test with wget
    # print "wget test : $url";
    # print "\n";
    # wget -nv = non verbose  
    # $access_server = `wget -cnv 1 $url > /dev/null && echo OK || echo NOK `;
    # $access_server = `wget -cnv 1 $url 2>&1 && echo OK || echo NOK `;

  # Test with curl
     # print "curl test : $url";
     # print "\n";
     # Redirect everything to null  &> /dev/null
     # $access_server = `curl -I $url > /dev/null && echo OK || echo NOK `;
     $access_server = `curl -I $url > /dev/null 2>&1 && echo UP || echo DOWN`;
  print " $access_server";
  print "\n";

############################### CASE 3 : No parameter defined
} else {
  print "Enter a parameter: 'a' (local Apache) or IP address or host";
  print "\n";
}