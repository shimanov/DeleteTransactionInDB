### ![](https://lh3.googleusercontent.com/VXxxfAZPVqUDYRCbsoLQV7tB6ugoF529pB4Av-e3F6NTP5YdKcfzFyIhBpJO-bLWrEjd=s64) Удаление транзакций из базы данных
#### **Для чего  это приложение**
Настоящее приложение призвано помочь вам самостоятельно удалять зависшие транзакции из "Сверки транзакции".
#### **Какой тип транзакций позволяет удалять приложение "ужкоршк"**
В текущей версии 1.0.0.0 можно удалять только транзакции с номером. Удаление транзакции без номера будет реализовано в ближайшей версии.
#### **Как запустить**
Для установки необходимо запустить Setup.msi
Для установки в тихом режиме необходимо выполнить команду ```msiexec /i c:\path\to\setup.msi /quiet```
#### **Как это работает**
1. Необходимо запустить приложение "Delete pending transactions" из меню Пуск - Все программы - Application for EAS OPS - Delete pending transactions
2. В открывшемся окне нажать на кнопку "Удаление зависшей транзакции с номером"
3. В окне Удаление транзакции с номером ввести номер транзакции полностью (например: Прод000001) и нажать на кнопку "Поиск транзакции".
4. Дождаться вывода результата
5. Удостовериться, что выведенные данные корректные
6. Нажать на кнопку "Удалить транзакцию" 
> 	ВНИМАНИЕ!
> Нажимая на кнопку "Удалить транзакцию" происходит безвозвратное удаление транзакции из базы данных. Восстановление удаленной транзакции невозможно!
7. Заново зайти в "Сверку транзакций" и убедиться, что транзакция удалена.
