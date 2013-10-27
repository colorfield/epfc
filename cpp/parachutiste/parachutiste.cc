#include <iostream>
#include <cmath>    // pour exp()
using namespace std;

int main()
{
  double masse(80.0);
  do {
    cout << "masse du parachutiste (>= 40) ?\n";
    cin >> masse;
  } while (masse < 40.0);

  double h0(39000.0);
  do {
    cout << "hauteur de depart du parachutiste (>= 250) ? \n";
    cin >> h0;
  } while (h0 < 250.0);

  /*******************************************
   * Completez le programme a partir d'ici.
   *******************************************/

  const double G = 9.81; // gravité (accélération)
  const double SOUND_SPEED = 343.0; // m/s
  const double A_LIMIT = 0.5;
  const double HEIGHT_LIMIT = 2500; // en mètres
  const double SURFACE_OPEN = 25.0; // surface parachute ouvert

  // modifié à l'ouverture du parachute
  double v0 = 0; // vitesse initiale
  double t0 = 0; // temps initial

  // description du parachutiste
  // masse déjà définie : masse
  // hauteur initiale déjà définie : h0
  double surface = 2.0; // surface du parachutiste en m2
  double v = v0; // vitesse courante
  double t = t0; // temps courant
  double h = h0; // hauteur courante
  double a = h0; // accélération courante

  // s = surface du sportif divisée par sa masse
  // sémantique de s ?
  double s = surface / masse;  // TODO : function 
  // sémantique de q ?
  double q = 0;
  // Dépassé la vitesse du son ?
  bool soundSpeedReached = false;
  bool maxSpeedReached = false;
  bool parachuteOpened = false;

  cout << "temps, altitude, vitesse, accélération\n";
  // TODO : function
  cout << t << ", " << h << ", " << v << ", " << a << "\n";
  
  do{

    ++t;
    
    // TODO : function 
    q = exp(-s * (t - t0));
    v = G/s * (1 - q) + v0 * q;
    h = h0 - G/s * (t - t0) - (v0 - G/s) / s * (1 - q);
    a = G - s * v;

    // ouverture du parachute à la hauteur limite
    if(h < HEIGHT_LIMIT && !parachuteOpened){
      parachuteOpened = true;
      surface = SURFACE_OPEN;
      s = surface / masse; // TODO : function
      v0 = v;
      t0 = t;
      h0 = h;
      cout << "------ Parachute ouvert ------\n";
    }   

    // atteint la vitesse du son ?
    if(v >= SOUND_SPEED && !soundSpeedReached){
      soundSpeedReached = true;
      cout << "Dépasse la vitesse du son, cours Forest, cours !\n";
    }

    // atteint la vitesse max ?
    if(a <= A_LIMIT && !maxSpeedReached){
      maxSpeedReached = true;
      cout << "Maximum velocity http://www.youtube.com/watch?v=Nwc0shJ2aYc!\n";
    }

    // TODO : pas d'altitude inférieure (dernière étape)
    // TODO : function 
    cout << t << ", " << h << ", " << v << ", " << a << "\n";
    
  } while(h > 0);

  /*******************************************
   * Ne rien modifier apres cette ligne.
   *******************************************/

  return 0;
}
