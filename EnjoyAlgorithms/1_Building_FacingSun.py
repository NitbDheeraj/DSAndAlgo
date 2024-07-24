# Given an input array height[] representing heights of the building, write a program to count the number of buildings facing sunset.
# It is assumed that height of all of the buildings are different
# input height[] = [7,4,8,2,9] 
# output = 3, Explanation  7 is the first building, 8 is the next building and 9 is the last buiding facing sun. 4 and 2 cannot see the 
# sunset as 7 and 8 are hiding it..

# input height[] = [2,3,4,5] => output: 4

def FacingSunCount(height, n):
    buildingCount = 1
    currMaxHeight = height[0]
    for i in range(n):
        if height[i] > currMaxHeight:
            buildingCount = buildingCount + 1
            currMaxHeight = height[i]
    return buildingCount

