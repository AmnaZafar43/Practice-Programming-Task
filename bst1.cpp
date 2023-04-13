#include <iostream>
using namespace std;
class Node
{
    int data;
    Node *left, *right;
    Node(int value)
    {
        data = value;
        left = NULL;
        right = NULL;
    }
};
int main()
{
    return 0;
}