Arr = [35,0,-3,101,4,-5,1,100,1,-4]
for i in range(0,len(Arr)):
          small = Arr[0]
          if small > Arr[i+1]:
              temp = small
              small = Arr[i+1]
              Arr[i+1] = temp
              
print(Arr)