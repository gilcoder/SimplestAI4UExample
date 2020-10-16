from ai4u.core import RemoteEnv

env = RemoteEnv()
env.open(0)
initial_state = env.step('get_state')
print('Action (tx, 5) change state ')
print("From: ", initial_state)
state = env.step('tx', 5)
print("To: ", state)
env.close()
