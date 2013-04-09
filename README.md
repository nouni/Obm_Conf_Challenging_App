Cette application a pour but d'afficher le nombre des accords (càd les accords qui ont le statut OUI) pour chaque télèopératrice en ordre descendant.
L'affichage est sous format d'un tableau à plusieurs colonnes où chaque ligne représente une télèopératrice.

Les colonnes sont les suivantes :
	<ol>
	<li>Nom de la télèopératrice</li>
	<li>Nombre d'accord pour :
		<ul><li>Lundi</li>
		<li>Mardi</li>
		<li>Mercredi</li>
		<li>Jeudi</li>
		<li>Vendredi</li></ul>
	</li>
	<li>Nombre d'accord pour :
		<ul><li>Semaine 1 du mois courant</li>
		<li>Semaine 2 du mois courant</li>
		<li>Semaine 3 du mois courant</li>
		<li>Semaine 4 du mois courant</li></ul>
	</li>
	<li>Nombre d'accord pour tout le mois courant</li>
	</ol>
Ce tableau est réactualisé pendant un temps T paramétrable pour chaque page web ouverte.
Et pour supporter les listes de résultat trops long l'administrateur a la possiblité de choisir le nombre de lignes à afficher à partir d'un OFFSET qui est saisi pour chaque page web ouverte ou seulement les résultats respectant une condition (par exemple nbr_accord_journée_courante >= 10).

L'administrateur a la possiblité aussi d'extraire les résultats vers un fichier CSV.