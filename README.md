# Контрольная работа, четверть I

## Текст задачи
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.*

**Примеры:**

    ["hello","2","world",":-)"] ->["2",":-)"]
    ["1234","1567","-2","computer science"] ->["-2"]
    ["Russia","Denmark","Kazan"] ->[]

## Декомпозиция задачи
Условимся, что первоначальные данные будем вводить с клавиатуры.    
*Перечислим блоки/методы которые нам могут понадобиться:*
1. Получение первоначальных строковых значений с консольного ввода
2. Создание массива строк из полученных значений
3. Подсчет количества элементов с длиной меньше 4 символов для выяснения размера конечного массива.
4. Создание конечного массива и запись всех элементов длиной меньше 4 символов . 
5. Вывод массива в консоль для проверки

## Выявление главного алгоритма.
* Блоки 1 и 2 отвечают за ввод данных, и могут быть не нужны, если в программу уже будут подавать готовый массив данных.
* Блок 3 - служебный, и нужен только чтобы мы могли правильно создать конечный массив. В принципе, этот подсчет можно добавить в другие методы с циклом по входному массиву данных, для оптимизации. Но в данной контрольной работе нужно показать декомпозицию, поэтому поставим его отдельно.
* блок печати 5 тоже служебный, и может изменяться в зависимости от требований к оформлению вывода. 
* Единственный блок из перечисленных, без которого не обойтись для решения задачи - это блок 4. Нарисуем для него блок-схему, как для главного алгоритма.
![](Flowchart1.png "Алгоритм главного метода")

## Улучшение кода.

* Для избавления от "магических чисел"(числа "3" из условия задачи), зададим значение переменной ***maxString*** методу **CountShortWords**, указывающую на нужную длину элементов в конечном массиве.  
По умолчанию поставим значение 1, тогда метод будет считать все не пустые элементы входного массива.
* Чтобы уменьшить количество входных аргументов для основного метода(избавимся от переменной ***shortCount***, указывающей нам длину массива), сделаем вызов функции подсчета общего числа коротких строк внутри метода.   
Отразим это на блок-схеме:
![Flowchart1-1](Flowchart1-1.png "Алгоритм с вызовом функции подсчета")

## Итоги.
*Итак, небольшой синопис после работы над контрольной, мысли и выводы.*

* Работа с Git - удобная и простая вещь, но можно наткнуться на неожиданные вещи. Хорошо, что в консоли вполне грамотные подсказки выводятся и всегда есть команда **--help** . Например, после создания локального репозитория, я создал новый удаленный и выбрал готовый **.gitingore**. Это вызвало проблемы при попытке запушить, так как Git включил защиту от перезаписи при разном содержимом. Поэтому нужно очень аккуратно выбирать момент, когда соединяешь рабочую и удаленную папку. Думаю, не последнюю роль тут как раз сыграют форки, от которых и будет создаваться локальный репозиторий при серьезных проектах.

* Работа с **readme**. Тут было несколько размышлений на тему, что документация очень серьезно может отличаться в зависимости от требований заказчика и сферы работы, и умение правильно её составлять будет первым требуемым навыком. И первым же предметом вопросов к начальству/cтаршему. Язык **Markdown** тут неплохо помог, как имеющий быстрый доступ через синтаксис с основным фишкам оформления.

* Декомпозиция. Ранее на этом особо не заостряли внимание, но это основа ООП. Было интересно разбить задачу на маленькие блоки, которые были бы полезны сами по себе.   
В данном случае обработка ввода заняла больше усилий, чем сама задача, хотя все можно было решить просто встроенным методом ***.Split*** . Но сказал А - говори и Б, а грамотно обрабатывать null в ReadLine нас не учили. И строить дальнейшие сложности на ровном месте , когда об этом не просят, я не стал -учусь вовремя останавливаться. Метод, чтобы быстро изменить входные данные с клавиатуры, я создал - и этого достаточно. Хоть в нем и нельзя ввести пустые элементы, так как 2 или 3 пробела подряд не будут обрабатываться, но сделать ввод циклом и отдельным словом так же имеет свои проблемы - например, слово-триггер выхода из цикла не сможет быть одним из элементов массива, что опять приводят нас к обработке null значений. 
Вобщем, если использовать ввод с клавиатуры - будь готов навешивать вокруг него кучу всякой всячины, и если без него можно обойтись - надо обойтись.

* Блок-схемы. Строгость кода и записи именно программного кода являются большим минусом, и  скорее всего, заставит редактировать названия переменных или ответвления после начала кодинга. Поэтому они полезны именно на этапе начальной концептуализации, понимания общей архитектуры, особенно в сложных задачах, и здесь возможность писать общими фразами внутри блоков схемы - это уже большой плюс. Пришло понимание, почему программисты практически не используют схемы между собой, а только лишь при взаимодействии с другими специалистами.

* Пора переходить к "большой" Visual Studio , так как многие вещи в VSCode попросту недоступны.Например, автодокументация методов в .XML.  Все-таки, не зря это начальный уровень,хоть он и мощнее многих текстовых редакторов.






