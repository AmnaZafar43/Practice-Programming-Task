#include <iostream>
using namespace std;
string parseData(string record, int field);
main()
{
    string result;
    result = parseData();
    cout << result;
}
string parseData(string record, int field);
{
    int commacount = 1;
    string item;
    int index = 0;
    while (true)
    {
        char ch = record[index];
        if (ch == '\0')
        {

            return item;
        }
        if (ch == ',')
        {
            commacount++;
        }
        else if (commacount == field)
        {
            item = item + ch;
        }
        index++;
    }
    return item;
}