Cette application a pour but d'afficher le nombre des accords (c�d les accords qui ont le statut OUI) pour chaque t�l�op�ratrice en ordre descendant.
L'affichage est sous format d'un tableau � plusieurs colonnes o� chaque ligne repr�sente une t�l�op�ratrice.

Les colonnes sont les suivantes :
	<ol>
	<li>Nom de la t�l�op�ratrice</li>
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
Ce tableau est r�actualis� pendant un temps T param�trable pour chaque page web ouverte.
Et pour supporter les listes de r�sultat trops long l'administrateur a la possiblit� de choisir le nombre de lignes � afficher � partir d'un OFFSET qui est saisi pour chaque page web ouverte ou seulement les r�sultats respectant une condition (par exemple nbr_accord_journ�e_courante >= 10).

L'administrateur a la possiblit� aussi d'extraire les r�sultats vers un fichier CSV.