Jeu de shoot them up

Vous devrez implémenter un jeu de shoot them up qui se jouera dans le terminal, et donc il n’y aura pas d’IHM à gérer. Le but du jeu sera de contrôler un vaisseau spatial se déplaçant horizontalement en bas du terminal qui devra détruire un maximum d’ennemis.

La destruction des ennemis apporte des points et parfois génère un bonus qui se mettra à tomber à partir de là où se trouvait le vaisseau ennemi, et le joueur devra le récupérer pour l’activer avant qu’il ne quitte l’écran.

1. LES CARACTERISTIQUES DU VAISSEAU

Le vaisseau possède les caractéristiques suivantes

· Une apparence (un caractère ascii qui le représentera dans la console)

· Une vitesse

· Une capacité de tir qui pourra être modifiée par les bonus récupérés dans le jeu. De base le tir est

o Rectiligne

o Illimité

o Dont la fréquence et les dégâts sont fixés au lancement du jeu

2. REGLES DU JEU

Le vaisseau peut se déplacer de gauche à droite en bas du terminal, les ennemis occupant le haut de l’écran : ils descendent petit à petit se déplaçant également de gauche à droite. Si les ennemis atteignent le bas du terminal la partie est perdue. Entre le vaisseau et les ennemis il y a des blocs de protections derrière lesquels le joueur peut s’abriter. Ces blocs seront détruits petit à petit par les tirs ennemis.

La partie commence avec 3 vies mais des bonus permettent d’en récupérer si le joueur en perd à condition de ne jamais dépasser le maximum de 3 vies. Lorsque le joueur se fait toucher par un tir ennemi, il perd une vie

3. LES ENNEMIS

Il y aura 2 types d’ennemis qui auront des types d’armes différents pour tirer sur le joueur

· Pawn : vaisseau petit, fragile (un tir suffit pour le détruire) pas très puissant (il tire une fois toutes les 5 secondes) mais rapide.

· Le boss : Lorsque le joueur arrive à la fin du niveau (réussir à tuer tous les monstres), un gros vaisseau apparait alors pour attaquer le joueur. Ce vaisseau fait la largeur du terminal. Toute sa surface pourra tirer des missile (et parfois des bonus) mais elle sera également entièrement vulnérable aux missiles du joueur. Le joueur devra réussir à le

toucher une cinquantaine de fois (à affiner selon la difficulté que l’on souhaite donner au jeu) pour le détruire.

4. LES BONUS

Parmi les possibilités de bonus que les ennemis pourront relâcher à leur destruction voici quelques propositions que vous pouvez compléter modifier et/ou enrichir…

· Tir multiple (3 tirs couvrant un angle de 60° vers l’avant )

· Tir plus puissant

· Invincibilité

· Bombe

· Récupération d’énergie

· Une vie supplémentaire
