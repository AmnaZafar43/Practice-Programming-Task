def MergeSort(A,p,q,r):
    L = []
    R = []
    n1 = q-p+1
    n2 = r-q
    for i in range(0,n1):
        L[i] = A[p+i-1]
    for j in range(0,n2):
        R[j] = A[q+j]
    print(L)
    print(R)