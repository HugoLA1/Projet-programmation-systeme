-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mar 04 Décembre 2018 à 08:03
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `masterchefinfo`
--

-- --------------------------------------------------------

--
-- Structure de la table `contient`
--

CREATE TABLE `contient` (
  `id` int(11) NOT NULL,
  `recetteNom` varchar(150) NOT NULL,
  `quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `contient`
--

INSERT INTO `contient` (`id`, `recetteNom`, `quantite`) VALUES
(1, 'Pizza Jeva', 1),
(2, 'Pizza Gorath', 1),
(3, 'Pizza Gorath', 1),
(3, 'Salade Mixte', 1),
(4, 'Pizza Gorath', 1),
(4, 'Salade Cesar', 1),
(4, 'Salade Mixte', 1),
(5, 'Pizza Jeva', 1),
(5, 'Salade Méditérranienne', 1),
(6, 'Pizza CCTL', 1),
(6, 'Pizza Gorath', 1),
(6, 'Pizza Jeva', 1),
(6, 'Pizza Juzzepe', 1),
(6, 'Pizza Londonienne', 1),
(6, 'Pizza Marguerite', 1),
(6, 'Pizza Mexicaine', 1),
(6, 'Pizza Montagnarde', 1),
(6, 'Pizza Reine', 1),
(6, 'Pizza Vegan', 1),
(7, 'Pizza Gorath', 1),
(7, 'Pizza Jeva', 1),
(7, 'Pizza Juzzepe', 1),
(7, 'Pizza Londonienne', 1),
(7, 'Pizza Marguerite', 1),
(7, 'Pizza Mexicaine', 1),
(7, 'Pizza Montagnarde', 1),
(7, 'Pizza Reine', 1),
(7, 'Pizza Vegan', 1),
(8, 'Pizza Vegan', 1),
(8, 'Salade Anchois', 1),
(8, 'Salade Campagnarde', 1),
(8, 'Salade Cesar', 1),
(8, 'Salade Méditérranienne', 1),
(8, 'Salade Mixte', 1),
(8, 'Salade Nordique', 1),
(8, 'Salade Poulet', 1),
(8, 'Salade Royal', 1),
(8, 'Salade Simple', 1),
(8, 'Salade Végétarienne', 1),
(9, 'Pizza CCTL', 1),
(9, 'Pizza Juzzepe', 1),
(9, 'Salade Cesar', 1),
(9, 'Salade Méditérranienne', 1),
(9, 'Salade Mixte', 1),
(9, 'Salade Poulet', 1),
(9, 'Salade Royal', 1),
(9, 'Salade Végétarienne', 1),
(10, 'Pizza Jeva', 1),
(10, 'Pizza Juzzepe', 1),
(10, 'Pizza Marguerite', 1),
(10, 'Pizza Montagnarde', 1),
(10, 'Pizza Reine', 1),
(10, 'Pizza Vegan', 1),
(11, 'Pizza Gorath', 1),
(11, 'Pizza Londonienne', 1),
(11, 'Pizza Mexicaine', 1),
(11, 'Salade Campagnarde', 1),
(12, 'Salade Nordique', 1),
(13, 'Pizza CCTL', 1),
(13, 'Pizza Montagnarde', 1),
(13, 'Salade Campagnarde', 1),
(13, 'Salade Royal', 1),
(14, 'Pizza Reine', 1),
(14, 'Salade Cesar', 1),
(15, 'Pizza Marguerite', 1),
(15, 'Salade Méditérranienne', 1),
(16, 'Pizza CCTL', 1),
(16, 'Pizza Reine', 1),
(16, 'Pizza Vegan', 1),
(16, 'Salade Campagnarde', 1),
(16, 'Salade Végétarienne', 1),
(17, 'Pizza Jeva', 1),
(18, 'Pizza CCTL', 1),
(18, 'Pizza Mexicaine', 1),
(18, 'Salade Royal', 1),
(19, 'Pizza Londonienne', 1),
(19, 'Salade Nordique', 1),
(22, 'Glace Chocolat', 1),
(23, 'Glace Vanille', 1),
(24, 'Glace Framboise', 1),
(25, 'Glace Fraise', 1),
(26, 'Glace Mangue', 1),
(27, 'Glace Ananas', 1),
(28, 'Glace Caramel', 1),
(29, 'Glace Yaourt', 1),
(30, 'Glace Pistache', 1),
(31, 'Glace Pomme', 1),
(32, 'Glace Ananas', 1),
(32, 'Glace Caramel', 1),
(32, 'Glace Chocolat', 1),
(32, 'Glace Fraise', 1),
(32, 'Glace Framboise', 1),
(32, 'Glace Mangue', 1),
(32, 'Glace Pistache', 1),
(32, 'Glace Pomme', 1),
(32, 'Glace Vanille', 1),
(32, 'Glace Yaourt', 1);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `id` int(11) NOT NULL,
  `nom` varchar(150) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `produit`
--

INSERT INTO `produit` (`id`, `nom`, `type`, `stock`) VALUES
(1, 'Sel', 'Produit longue conservation', 1000),
(2, 'Poivre', 'Produit longue conservation', 1000),
(3, 'Boeuf', 'Produit frais', 1000),
(4, 'Poulet', 'Produit frais', 1000),
(5, 'Saumon', 'Produit frais', 1000),
(6, 'Pâte à pizza', 'Produit congelé', 3000),
(7, 'Sauce Tomate', 'Produit frais', 1000),
(8, 'Salade', 'Produit frais', 1000),
(9, 'Tomate', 'Produit frais', 1000),
(10, 'Mozzarella', 'Produit frais', 1000),
(11, 'Cheddar', 'Produit congelè', 1000),
(12, 'Pomme de terre', 'Produit longue conservation', 1000),
(13, 'Lardon', 'Produit congelè', 1000),
(14, 'Jambon', 'Produit frais', 1000),
(15, 'Olive', 'Produit frais', 1000),
(16, 'Champignon', 'Produit frais', 1000),
(17, 'Anchois', 'Produit longue conservation', 1000),
(18, 'Chorrizo', 'Produit longue conservation', 1000),
(19, 'Bacon', 'Produit longue conservation', 1000),
(22, 'Glace Chocolat', 'Produit congelé', 1000),
(23, 'Glace Vanille', 'Produit congelé', 1000),
(24, 'Glace Frambroise', 'Produit congelé', 1000),
(25, 'Glace Fraise', 'Produit congelé', 1000),
(26, 'Glace Mangue', 'Produit congelé', 1000),
(27, 'Glace Ananas', 'Produit congelé', 1000),
(28, 'Glace Caramel', 'Produit congelé', 1000),
(29, 'Glace Yaourt', 'Produit congelé', 1000),
(30, 'Glace Pistache', 'Produit congelé', 1000),
(31, 'Glace Pomme', 'Produit congelé', 1000),
(32, 'Spéculoos', 'Produit longue conservation', 1000);

-- --------------------------------------------------------

--
-- Structure de la table `recette`
--

CREATE TABLE `recette` (
  `recetteNom` varchar(150) NOT NULL,
  `prix` decimal(15,3) DEFAULT NULL,
  `instructions` varchar(150) NOT NULL,
  `categorie` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `recette`
--

INSERT INTO `recette` (`recetteNom`, `prix`, `instructions`, `categorie`) VALUES
('Glace Ananas', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Caramel', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Chocolat', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Fraise', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Framboise', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Mangue', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Pistache', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Pomme', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Vanille', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Glace Yaourt', '5.000', 'Ajouter; Servir;', 'Dessert'),
('Pizza CCTL', '20.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Gorath', '15.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Jeva', '10.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Juzzepe', '13.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Londonienne', '12.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Marguerite', '9.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Mexicaine', '13.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Montagnarde', '12.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Reine', '10.000', 'Ajouter; Four; Servir;', 'Plat'),
('Pizza Vegan', '11.000', 'Ajouter; Four; Servir;', 'Plat'),
('Salade Anchois', '8.000', 'Ajouter ; Mélanger ;', 'Entrée'),
('Salade Campagnarde', '10.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Cesar', '10.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Méditérranienne', '9.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Mixte', '12.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Nordique', '11.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Poulet', '9.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Royal', '13.000', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Simple', '6.500', 'Ajouter; Mélanger; Servir;', 'Entrée'),
('Salade Végétarienne', '8.000', 'Ajouter; Mélanger; Servir;', 'Entrée');

-- --------------------------------------------------------

--
-- Structure de la table `ustensibles`
--

CREATE TABLE `ustensibles` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `ustensibles`
--

INSERT INTO `ustensibles` (`id`, `nom`) VALUES
(1, 'Cuillère en bois'),
(2, 'Four');

-- --------------------------------------------------------

--
-- Structure de la table `utiliser`
--

CREATE TABLE `utiliser` (
  `recetteNom` varchar(150) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `utiliser`
--

INSERT INTO `utiliser` (`recetteNom`, `id`) VALUES
('Glace Ananas', 1),
('Glace Caramel', 1),
('Glace Chocolat', 1),
('Glace Fraise', 1),
('Glace Framboise', 1),
('Glace Mangue', 1),
('Glace Pistache', 1),
('Glace Pomme', 1),
('Glace Vanille', 1),
('Glace Yaourt', 1),
('Pizza CCTL', 1),
('Pizza Gorath', 1),
('Pizza Jeva', 1),
('Pizza Juzzepe', 1),
('Pizza Londonienne', 1),
('Pizza Marguerite', 1),
('Pizza Mexicaine', 1),
('Pizza Montagnarde', 1),
('Pizza Reine', 1),
('Pizza Vegan', 1),
('Salade Anchois', 1),
('Salade Campagnarde', 1),
('Salade Cesar', 1),
('Salade Méditérranienne', 1),
('Salade Mixte', 1),
('Salade Nordique', 1),
('Salade Poulet', 1),
('Salade Royal', 1),
('Salade Simple', 1),
('Salade Végétarienne', 1),
('Pizza CCTL', 2),
('Pizza Gorath', 2),
('Pizza Jeva', 2),
('Pizza Juzzepe', 2),
('Pizza Londonienne', 2),
('Pizza Marguerite', 2),
('Pizza Mexicaine', 2),
('Pizza Montagnarde', 2),
('Pizza Reine', 2),
('Pizza Vegan', 2);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `contient`
--
ALTER TABLE `contient`
  ADD PRIMARY KEY (`id`,`recetteNom`),
  ADD KEY `CONTIENT_Recette0_FK` (`recetteNom`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `recette`
--
ALTER TABLE `recette`
  ADD PRIMARY KEY (`recetteNom`);

--
-- Index pour la table `ustensibles`
--
ALTER TABLE `ustensibles`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `utiliser`
--
ALTER TABLE `utiliser`
  ADD PRIMARY KEY (`recetteNom`,`id`),
  ADD KEY `UTILISER_Ustensibles0_FK` (`id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `produit`
--
ALTER TABLE `produit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT pour la table `ustensibles`
--
ALTER TABLE `ustensibles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `contient`
--
ALTER TABLE `contient`
  ADD CONSTRAINT `CONTIENT_Produit_FK` FOREIGN KEY (`id`) REFERENCES `produit` (`id`),
  ADD CONSTRAINT `CONTIENT_Recette0_FK` FOREIGN KEY (`recetteNom`) REFERENCES `recette` (`recetteNom`);

--
-- Contraintes pour la table `utiliser`
--
ALTER TABLE `utiliser`
  ADD CONSTRAINT `UTILISER_Recette_FK` FOREIGN KEY (`recetteNom`) REFERENCES `recette` (`recetteNom`),
  ADD CONSTRAINT `UTILISER_Ustensibles0_FK` FOREIGN KEY (`id`) REFERENCES `ustensibles` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
