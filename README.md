1. Создайте класс MyList. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List. Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  

2. Создайте класс MyDictionary. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary . Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.

3. Создайте расширяющий метод: public static T[] GetArray(this MyList list) Примените расширяющий метод к экземпляру типа MyList, разработанному в домашнем задании 2 для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 

4. \* Создайте класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(), который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). 