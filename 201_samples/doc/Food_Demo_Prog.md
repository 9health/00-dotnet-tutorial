
# Description

This is a sample food program to input foods and meals from CLI with provided classes from `201_samples` library.

# Requirements

- This should have an interface from command line to input foods and meals in 3 ways
  - Direct input by entering each field sequentially.
  - Batch input by using `|` separtor to input multiple fields.
    - Fields: `Food Name | Food Time | Food Steps | Food Views | IngredientNum`
    - Example: `Thịt gà rán | 15 | 5`
  - File input (`foods.csv` or `meals.csv`) by using a predefined format to input multiple rows.
  - Command file (`cmd.txt`) to CRUD and search foods, meals (**2022/Oct/27 Updates**)
- Libraries
  - .NET 6
  - .NET EF Core using SQLite
- API-oriented
- Code should be tested easily (**Design for Test**)

# Basic Design

## CLI User Interface/User Interaction

### Principles
- CRUD (create, read, update, delete)

### Flow Level 1

`S00` What do you want to do?
  1. List (or output) => `S10`
  2. Create (or add, input)  => `S20`
  3. Update => `S30`
  4. Delete => `S40`
  5. Search (find) => `S50`
  6. Quit (exit)

`S10` What do you want to list?
  1. Foods
  2. Meals
  3. All

`S20` What do you want to create?
  1. Foods
  2. Meals
  3. All (_optional_)

`S30` What do you want to update?
  1. Foods
  2. Meals
  3. All (_optional_)

`S40` What do you want to delete?
  1. Foods
  2. Meals
  3. All (**dangerous!!!**)

`S50` What do you want to find?
  1. Foods
  2. Meals
  3. All (_optional_)

### Flow Level 2

### Notes
- FDP is synonym for Food Demo Program
- If there are **30,000** foods at `S10`, should it be listed all?
- How to parition FDP to reuse or extend functionality later?
- `csv` input file is only used to input large number of foods. How to control FDP from command line such as delete foods?
  - Use more general file such as command file `cmd.txt` to interact with FDP
  - `cmd.txt` format is `CMD | REG | VAL`
    - Commands `CMD` are
      - `LIST`
      - `CREATE`
      - `UPDATE`
      - `DELETE`
    - Register `REG` are
      - `Foods`
      - `Meals`
    - Value `VAL` are
      - For `Foods` register
        - `Food Name | Food Time | Food Steps | Food Views | IngredientNum`
      - For `Meals` register
        - `Meal Name | FoodId Item 1, FoodId Item 2`
    - Example
      ```
      LIST   | Foods
      CREATE | Foods | Trung ran   | 10
      CREATE | Foods | Rau cai xao | 15
      CREATE | Foods | Thit luoc   | 20
      CREATE | Foods | Nuoc mam    | 4
      CREATE | Foods | Rau muong luoc | 20
      CREATE | Foods | Dau phu luoc   | 5
      CREATE | Foods | Nem ran        | 60
      LIST
      UPDATE | Foods | ID | 3 | 4
      LIST
      DELETE | Foods | ID | 5
      LIST
      ```

- How to test code efficiently? For example: when code is updated and regression is ran, PASSED or FAILED testcases should be reported.

# Detailed Design
