# Решение
Берем два массива _(array1, array2)_. Так как нам необходимо выявить все элементы, являющиеся менее или равными трем символам, мы используем длину массива и проверяем каждые его элемент. Соответсвенно, используем условие "<=3". 
* При соблюдении данного условия, наш элемент _array1_ заносится в _number_ элемента _array2._
* Переменная _number_ увеличивается(+1) 
* Возвращаемся к циклу _for_, где i ,так же увеличивается (+1).
* Данное действие будет совершаться до окончания проверки всех элементов массива.