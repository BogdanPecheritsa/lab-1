# Лабораторна робота №1: Принципи програмування

## Опис застосованих принципів

1. **DRY (Don't Repeat Yourself)**
   - Код розділено на окремі класи (Money, Product, Warehouse, Reporting) без дублювання логіки.

2. **KISS (Keep It Simple, Stupid)**
   - Структура коду проста й зрозуміла, кожен клас виконує одну роль.

3. **SOLID Principles**
   - **Single Responsibility Principle:** Кожен клас має свою відповідальність (наприклад, клас Money відповідає лише за операції з грошима).
   - **Open/Closed Principle:** Класи можна розширювати без модифікації існуючого коду.
   - **Liskov Substitution Principle:** Методи класів та їх поведінка дозволяють легко замінювати об’єкти.
   - **Interface Segregation Principle:** Якщо потрібно, можна створювати інтерфейси для кожного класу.
   - **Dependency Inversion Principle:** Компоненти взаємодіють через методи та абстракції, а не через конкретні імплементації.

4. **YAGNI (You Aren’t Gonna Need It)**
   - Код містить лише необхідний функціонал для поточного завдання, без зайвих надбудов.

5. **Composition Over Inheritance**
   - Використання композиції: клас Warehouse містить список об’єктів типу Product.

6. **Program to Interfaces not Implementations**
   - Планувалося забезпечити гнучкість, використовуючи методи, які можна перейняти через інтерфейси (за потребою).

7. **Fail Fast**
   - Прості перевірки і логіка, що дозволяють швидко виявляти помилки.

## Посилання на код
- [Money.cs (рядки 1-30)](./Money.cs)
- [Product.cs (рядки 1-35)](./Product.cs)
- [Warehouse.cs (рядки 1-30)](./Warehouse.cs)
- [Reporting.cs (рядки 1-20)](./Reporting.cs)
- [Program.cs (рядки 1-40)](./Program.cs)
