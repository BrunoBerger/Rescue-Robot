
import numpy as np
import os
import ikpy
from ikpy.chain import Chain
from ikpy.link import OriginLink, URDFLink
import ikpy.utils.plot as plot_utils
import matplotlib.pyplot as plt

print(os.getcwd())

urdfPath2= "RescueBot_Baugruppe.SLDASM/urdf/RescueBot_Baugruppe.SLDASM.urdf"
my_chain = ikpy.chain.Chain.from_urdf_file(urdfPath1)

target_position = [ 15, 15, 15]

print("The angles of each joints are : ", my_chain.inverse_kinematics(target_position))


# Optional: support for 3D plotting in the NB
# If there is a matplotlib error, uncomment the next line, and comment the line below it.
# %matplotlib inline
# %matplotlib widget

fig, ax = plot_utils.init_3d_figure()
# my_chain.plot(my_chain.inverse_kinematics(target_position), ax, target=target_vector)
my_chain.plot(my_chain.inverse_kinematics(target_position), ax, target=None)
plt.xlim(-7, 7)
plt.ylim(-7, 7)
plt.show()
