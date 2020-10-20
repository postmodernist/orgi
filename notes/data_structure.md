# Orgi data structure

## Сутності (да да в виде гноміка)):
- Користувач
- Задача
- Проекти
- Мітки
- Фільтри
- Календар

### User:
- UserID
- First name
- Second name
- Email
- Password
- regiter_at
- Birth_date

### Task:
- TaskID
- UserID
- Task_name
- Priority
- Created_at
- Shedule
- LabelId
- ProjectID

### Project
- ProjectID
- UserID
//collaborators
- Display_as (list or board)
- LabelID

### Label:
- UserId
- LabelID
- Name

