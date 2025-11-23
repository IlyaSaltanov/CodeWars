def per(n):
    if len(str(n)) == 1:
        return []
    massive = []
    while len(str(n)) != 1:
        if 0 in str(n):
            massive.append(0)
            break
        else:
            sp = [int(i) for i in str(n)]
            tamp = 1
            for q in sp:
                tamp = tamp * q
            massive.append(tamp)
            n = tamp
    return massive
    
