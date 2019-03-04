# Mars Rover Kata

![Rover](../art/rover.jpg)

Vous travaillez à la Nasa dans l'équipe qui construit Rover, un véhicule autonome qui explore la surface de Mars.

## Mission

Développez une API qui traduit les commandes envoyées depuis la Terre en instruction comprises par Rover et qui renvoie la position du Rover.

Par contre les communications entre la Terre et Mars ne se font pas en 4G :

- un message arrive entre environ 3 minutes et 21 minutes
- le débit varie entre environ 1,75 KB/s et 0,5 KB/s

L'équipe qui gère les communications a donc mis en place un protocole texte très simple.

Attention, comme toute aventure l'exploration de Mars aura son lot de surprise, soyez prêts à vous adapter !

## Spécifications

- Mars est représentée par une grille de 10x10. Attention, comme toutes les planètes Mars est sphérique.
- Mars contient des obstacles qui bloquent Rover.
- Les commandes envoyées sont : 
  - `F` : avancer Rover vers l'avant
  - `L` : faire pivoter Rover vers la gauche
  - `R` : faire pivoter Rover vers la droite
- Rover reçoit un ensemble de commande
- Rover envoi ses coordonnées et la direction vers laquelle il regarde (`N`, `S`, `E`, `W`) sous la forme `x:y:z`
- Rover est initialement en coordonnées `0:0:N`
- Si Rover rencontre un obstacle, il s'arrête et envoie ses coordonnées sous la forme `O:x:y:z`

## Exemples

**Rover reçoit une commande vide**

- Étant donné que Rover soit aux coordonnées `0:0:N`
- Quand Rover reçoit ` `
- Alors Rover envoi les coordonnées `0:0:N`

**Rover reçoit plusieurs commandes**

- Étant donné que Rover soit aux coordonnées `0:0:N`
- Quand Rover reçoit `FRF`
- Alors Rover envoi les coordonnées `1:1:E`

**Rover rencontre un obstacle**

- Étant donné que Rover soit aux coordonnées `0:0:N` et qu'il y a un obstacle en `1:1`
- Quand Rover reçoit `FRF`
- Alors Rover envoi les coordonnées `O:0:1:E`

**Rover dépasse les limites de la grille**

- Étant donné que Rover soit aux coordonnées `0:0:N` et que Mars soit représentée par une grille de 10x10
- Quand Rover reçoit `RRF`
- Alors Rover envoi les coordonnées `0:9:S`
