# All tasks

1. Смена имени объектов:  создать сцену в Unity, разместить с помощью редактора в сцене три объекта - два куба и сферу. Из-под кода:
    1. Получить ссылку на сферу с помощью FindObjectOfType();
    2. Получить ссылку на один куб с помощью FindWithTag();
    3. Получить ссылку на второй куб с помощью Find().
    У всех объектов поменять имя.
    
2. Создайте сцену в Unity. На сцене сгенирируйте  N кубов. В консоль вывести значение среднего арифметического суммы координат позиций нахождения элементов. Обязательные условия: 
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены на одной оси.
    - Кубы расположены на равном расстоянии друг от друга
    - Количество генерируемых кубов N задается в скрипте в Unity Editor. 
    
3. Создайте сцену в Unity. На сцене сгенирируйте из кода N кубов и N сфер. Обязательные условия:  
    - Объекты при появлении на сцену должны чередоваться (сфера, куб, сфера ,куб и так далее)
    - Объекты на сцене расположены на равном расстоянии друг от друга на одной оси
    - Количество генерируемых кубов N задается в скрипте в Unity Editor.
    
4. Создать сцену в Unity. На сцене создать первый ряд кубов с произвольным значением N. Написать программу, которая создаст второй ряд сфер, используя координаты x или z в обратном порядке, при этом каждая позиция Y элементов второго массива будет увеличивать на 2 от предыдущего. Обязательные условия:  
    - Количество генерируемых кубов N задается в скрипте в Unity Editor.
    - Кубы и сферы не должны пересекаться при появлении 
    
5. Создать сцену в Unity. Создать N кубов лежащих в одной плоскости (случайно) . Отсортировать массив в порядке возрастания по оси Х. Обязательные условия:  
    - Кубы не должны пересекаться
    - Количество генерируемых кубов N задается в скрипте в Unity Editor. 
    
6. Создать сцену в Unity. Создать N кубов лежащих в одной плоскости. Раскрасить кубы в цвета радуги. Обязательные условия:  
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены на одной оси.
    - Кубы расположены на равном расстоянии друг от друга
    - Минимум кубов в сцене 9
    
7. Создать сцену в Unity. Создать двумерный массив кубов ( 10 х 10 ).  Кубы под главной диагональю вращать по часовой стрелки, кубы на главной диагонали вращать по оси Х, кубы над главной диагональю вращать против часовой стрелки.  Обязательные условия:  
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены в одной плоскости.
    - Кубы расположены на равном расстоянии друг от друга
    
8. Создать сцену в Unity. Создать двумерный массив кубов ( 10 х 10 ).  Кубы под побочной диагональю вращать по часовой стрелки, кубы на побочной диагонали вращать по оси Х, кубы над побочной диагональю вращать против часовой стрелки.  Обязательные условия: 
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены в одной плоскости.
    - Кубы расположены на равном расстоянии друг от друга
    
9. Создать сцену в Unity. Создать двумерный массив кубов ( 10 х 10 ). Появление каждого куба в сцене должно происходить через N секунд. Обязательные условия:  
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены в одной плоскости.
    - Кубы расположены на равном расстоянии друг от друга
    
10. Создать сцену в Unity. Создать двумерный массив кубов ( 10 х 10 ). Появление каждого куба в сцене должно происходить по нажатию на клавишу Space . Обязательные условия: 
    - Кубы не должны пересекаться при появлении 
    - Кубы расположены в одной плоскости.
    - Кубы расположены на равном расстоянии друг от друга
    
11. Создайте трехмерный массив. На каждый куб добавить компонент RigidBody. Написать приложение, в котором при нажатии на кнопку на экране трехмерный массив кубов взрывался. Обязательные условия:  
    - За точку взрыва принимать центр одного из кубов, который можно указать в UnityEditor. 
    - Кубы расположены на равном расстоянии друг от друга
    - Кубы не должны пересекаться при появлении
    - Кнопка реализована в Canvas
    
12. Создать сцену в Unity. Реализовать возможность открыть дверь FPS Controller’ом. 
    Обязательные условия: 
    - Использовать StandardAssets,  FPS Controller. 
    - Использовать Hinge Joint 
    - Не использовать анимацию и внешние скрипты 
    
13. Создать сцену в Unity. Расставить в сцене объекты с различными именами. При наведении на объект курсором мыши, отображать под курсором мыши имя объекта. Обязательные условия: 
    - Все объекты должны находится в поле зрения камеры 
    - Использовать функцию Raycast 
    - Текст выводить в Canvas