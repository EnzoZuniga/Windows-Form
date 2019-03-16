## Windows-Form ##
### TP: Fenêtre Mère/Fille ###

Le but du Tp est de gérer deux fenêtres dans une même application et de découvrir la gestion de deux fenêtres qui communiquent entre elles au moyen de méthodes, d'accesseurs et d'évènements.

Les outils mis en oeuvre:
* Git
* Visual Studio
* C#
* Windows Form

Dans un premier temps, il fut nécessaire de créer la fenêtre Mère.
Celle-ci est entre autre la fenêtre par défaut générer par la solution Windows Form.
Ainsi, afin de ne pas la laisser vide, nous avons fait le choix d'ajouter différentes fonctionnalités:

![Mere.png](http://image.noelshack.com/fichiers/2018/42/5/1539939751-mere.png)

1. Bouton New: Instancie une nouvelle fenêtre et l'ajouter à la List Box.
La mère ayant de nombreuses Filles, celles-ci seront stockées dans un objet de type ArrayList géré par la fenêtre mère:
```cs
public partial class FMere : Form
{
  List<FFille> lesFilles;
  private int nombreFille; //Compteur permettant de numéroter les filles créées.
  private string nomMere; //Permet de nommer les filles créées.
  ..
  
  public FMere()
  {
    InitializeComponent();
    btnNew.Click += new EventHandler(btnNew_Click); //Abbonnement de la fenêtre FMere à l'événement Click du bouton btnNew
  }
  
  private void btnNew_Click(object sender, EventArgs e)
  {
    nombreFille = nombreFille + 1;
    FFille nouvelleFenetre = new FFille(this, nombreFille);
    lesFilles.Add(nouvelleFenetre);
    lbLesFilles.Items.Add("Fille n°" + nombreFille);
  }
}
```
  
2. Bouton Close: Ferme la fenêtre préalablement séléctionnée dans la List Box et l'efface de la List Box (Elle n'existe plus en mémoire).
3. List Box: Liste les fenêtres Fille instanciées.
4. Bouton Show: Ouvre, affiche la fenêtre Fille selectionnée dans la List Box.
5. Bouton Hide: Cache la fenêtre fille selectionnées dans la List Box.
6. Bouton Show Dialog: Ouvre une fenêtre fille selectionnée dans la List Box en tant que Show Dialog.

![FilleNew.png](http://image.noelshack.com/fichiers/2018/42/5/1539939823-fillenew.png)

![FilleMere.png](http://image.noelshack.com/fichiers/2018/42/5/1539939856-fillemere.png)


