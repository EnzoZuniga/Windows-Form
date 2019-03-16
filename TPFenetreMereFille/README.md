## Windows-Form ##
### TP: Fenêtre Mère/Fille ###

Le but du TP est de gérer deux fenêtres dans une même application et de découvrir la gestion de deux fenêtres qui communiquent entre elles au moyen de méthodes, d'accesseurs et d'évènements.

Les outils mis en oeuvre:
* Visual Studio
* C#
* Windows Form

Nous avons tout d'abord créé la fenêtre "mère".
Celle-ci est entre autre la fenêtre par défaut générer par la solution Windows Form.
Ainsi, afin de ne pas la laisser vide, nous avons fait le choix d'ajouter différentes fonctionnalités:

![Mere.png](http://image.noelshack.com/fichiers/2018/42/5/1539939751-mere.png)

1. Le bouton "New" instancie une nouvelle fenêtre et l'ajoute à la ListBox.
La mère ayant de nombreuses Filles, celles-ci seront stockées dans une ArrayList géré par la fenêtre mère:
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
![FilleNew.png](http://image.noelshack.com/fichiers/2018/42/5/1539939823-fillenew.png)

2. Le nouton "close" ferme la fenêtre préalablement séléctionnée dans la ListBox et l'efface de celle-ci(Même de la mémoire).
3. La ListBox liste les fenêtres "fille" instanciées.

4. Le bouton "show", ouvre et affiche la fenêtre "fille" selectionnée dans la ListBox.

![FilleMere.png](http://image.noelshack.com/fichiers/2018/42/5/1539939856-fillemere.png)

5. Le bouton "hide" cache la fenêtre "fille" selectionnées dans la ListBox.

6. Le bouton "show dialog" ouvre une fenêtre "fille" selectionnée dans la ListBox en tant que "show dialog".

