import os
import argparse
import numpy as np
import matplotlib.pyplot as plt
import ikpy.utils.plot as plot_utils
from ikpy.chain import Chain


# load the greifarm-chain from the exported urdf file from solidworks
def getChain():
    urdfPath= "RescueBot_Baugruppe.SLDASM/urdf/RescueBot_Baugruppe.SLDASM.urdf"
    return Chain.from_urdf_file(urdfPath)

# draws chain in target-position in a window
def plotChain(my_chain, args):
    print("Relative object-position is ", args)
    target_position = [args["x"], args["y"], args["z"]]

    # plot chain vectors
    fig, ax = plot_utils.init_3d_figure()
    print("The angles of each joints are : ", my_chain.inverse_kinematics(target_position))
    my_chain.plot(getChainPos(my_chain, target_position), ax, target=None)
    # my_chain.plot(getChainPos(my_chain, target_position), ax, target=target_vector)

    # show the vectors in a matplotlib-window
    plt.xlim(-2, 2)
    plt.ylim(-2, 2)
    plt.show()

# Calculates vectors using magic
def getChainPos(my_chain, target_position):
    return my_chain.inverse_kinematics(target_position)


if __name__ == "__main__":
    # setup cmd-line arguments for custom position
    ap = argparse.ArgumentParser()
    ap.add_argument("-x", type=float, default=15,
    help="set relative x position")
    ap.add_argument("-y", type=float, default=-7,
    help="set relative y position")
    ap.add_argument("-z", type=float, default=2,
    help="set relative z position")
    args = vars(ap.parse_args())

    my_chain = getChain()
    plotChain(my_chain, args)
