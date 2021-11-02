# TheCardGame---Generic
Задание 1. Программа «Карточная игра!»<br />
Создать модель карточной игры.<br />
Требования:<br />
1. Класс Game формирует и обеспечивает:<br />
1.1.1. Список игроков (минимум 2);<br />
1.1.2. Колоду карт (36 карт);<br />
1.1.3. Перетасовку карт (случайным образом);<br />
1.1.4. Раздачу карт игрокам (равными частями каждому игроку);<br />
1.1.5. Игровой процесс. Принцип: Игроки кладут по одной карте. У кого
карта больше, то тот игрок забирает все карты и кладет их в конец своей
колоды. Упрощение: при совпадении карт забирает первый игрок,
шестерка не забирает туза. Выигрывает игрок, который забрал все карты.<br />
2. Класс Player (набор имеющихся карт, вывод имеющихся карт).<br />
3. Класс Karta (масть и тип карты (6-10, валет, дама, король, туз).