# Тестовое задание
## Подробности реализации
Проект реализован в виде приложения WPF. При необходимости можно вынести в отдельную библиотеку.
Создан интерфейс IFigure от него унаследован абстрактный класс Figure. Также Figure наследует UIElement, это необходимо для отображения фигур на экране, это один из способов реализации рендера фигуры.
Каждая конкретная фигура наследуется от Figure, переопределяется метон OnRender(), в нем описана логика отображения конкретного эллемента.
## Тестирование
Для тестирования создано базовое представление, оно не раскрывает все фичи написанной программы, оно лишь дает возможность протестировать базовые функции. В поля уже введены тестовые данные, при желании их можно изменить. Проверки на пустые поля нет так как задача этого не предусматривала, в поля можно ввести только цифры.
## Обатная связь 
ТГ - @Nomoreelse
