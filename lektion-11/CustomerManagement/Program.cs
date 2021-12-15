using CustomerManagement.Handlers;

IMenuHandler menuHandler = new MenuHandler();

int menuOption = -1;

do
{
    menuOption = menuHandler.MenuOptions();

    switch (menuOption)
    {
        case 1:
            menuHandler.MenuOptionAdd();
            break;
        case 2:
            menuHandler.MenuOptionRemove();
            break;
        case 3:
            menuHandler.MenuOptionGet();
            break;
        case 4:
            menuHandler.MenuOptionView();
            break;
        case 5:
            menuHandler.MenuOptionSave();
            break;
        default:
            break;
    }
} while (menuOption != 0);
